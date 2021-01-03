require('dotenv').config();

const mongoose = require('mongoose');
const Schema = mongoose.Schema;
mongoose.connect(process.env.MONGO_URI, { useNewUrlParser: true, useUnifiedTopology: true });


/*
const personSchema = new Schema({
  name: {type: String, required: true},
  surname: {type: String, required: true},
  age: Number,
  favoriteFoods: [String],
  country: String
});

const Person = mongoose.model("Person", personSchema);
*/


const personSchema = require('./Person');

const Person = mongoose.model("Person", personSchema);

let Juan = new Person();
Juan.name = 'Juan';
Juan.surname = 'Rosales';
Juan.favoriteFoods = ['Asado', 'Sushi', 'Helado'];
console.log(Juan);


/*
MongoDB and Mongoose - Create and Save a Record of a Model

In this challenge you will have to create and save a record of a model.
Within the createAndSavePerson function, create a document instance using the Person model constructor you built before. 
Pass to the constructor an object having the fields name, age, and favoriteFoods. 
Their types must conform to the ones in the personSchema. Then, call the method document.save() on the returned document instance. 
Pass to it a callback using the Node convention. This is a common pattern; all the following CRUD methods 
take a callback function like this as the last argument.
*/

const createAndSavePerson = (done) => {
  var Pedro = new Person({name: 'Pedro', surname: 'Chivilcoy', age: 23, favoriteFoods: ['Milanesa', 'Guiso', 'Choripan']});
  
  Pedro.save(function(err, data){
    if(err) return console.log(err);
    done(null, data);
    });
  };


/*
MongoDB and Mongoose - Create Many Records with model.create()

Sometimes you need to create many instances of your models, e.g. when seeding a database with initial data. 
Model.create() takes an array of objects like [{name: 'John', ...}, {...}, ...] as the first argument, and saves them all in the db.

Modify the createManyPeople function to create many people using Model.create() with the argument arrayOfPeople.
Note: You can reuse the model you instantiated in the previous exercise.
*/

var arrayOfPeople = [
  {name: 'Teresa', surname: 'Juárez', age: 65, favoriteFoods: ['Vodka', 'Gin']},
  {name: 'Francisco', surname: 'Gil', age: 42, favoriteFoods: ['Fish', 'Soup']},
  {name: 'Lucía', surname: 'Cassano', age: 27, favoriteFoods: ['Fruits', 'Meat']}
];

const createManyPeople = (arrayOfPeople, done) => {
  Person.create(arrayOfPeople, function (err, people){
    if(err) return console.log(err);
    done(null, people);
    });
  };


/*
Use model.find() to Search Your Database

In its simplest usage, Model.find() accepts a query document (a JSON object) as the first argument, then a callback. 
It returns an array of matches. It supports an extremely wide range of search options. Read more in the docs.
Modify the findPeopleByName function to find all the people having a given name, using Model.find() -> [Person]
Use the function argument personName as the search key.
*/

const findPeopleByName = (personName, done) => {
  Person.find({name: personName}, (err, match) => {
      if(err) return console.log(err);
      done(null, match);
  });
};


/*
Use model.findOne() to Return a Single Matching Document from Your Database

Model.findOne() behaves like .find(), but it returns only one document (not an array), 
even if there are multiple items. It is especially useful when searching by properties that you have declared as unique.
Modify the findOneByFood function to find just one person which has a certain food in the person's favorites, 
using Model.findOne() -> Person. Use the function argument food as search key.
*/

const findOneByFood = (food, done) => {
  Person.findOne({favoriteFoods: food}, (err, match) => {
      if(err) return console.log(err);
      done(null, match);
  });
};


/*
Use model.findById() to Search Your Database By _id

When saving a document, MongoDB automatically adds the field _id, and set it to a unique alphanumeric key. 
Searching by _id is an extremely frequent operation, so Mongoose provides a dedicated method for it.
Modify the findPersonById to find the only person having a given _id, using Model.findById() -> Person. 
Use the function argument personId as the search key.
*/
const findPersonById = (personId, done) => {
  Person.findById({_id: personId}, (err, match) => {
    if(err) return console.log(err);
      done(null, match);
  });
};


/*
Perform Classic Updates by Running Find, Edit, then Save

In the good old days, this was what you needed to do if you wanted to edit a document, 
and be able to use it somehow (e.g. sending it back in a server response). 
Mongoose has a dedicated updating method: Model.update(). It is bound to the low-level mongo driver. 
It can bulk-edit many documents matching certain criteria, but it doesn’t send back the updated document, only a 'status' message. 
Furthermore, it makes model validations difficult, because it just directly calls the mongo driver.

Modify the findEditThenSave function to find a person by _id (use any of the above methods) 
with the parameter personId as search key. 
Add "hamburger" to the list of the person's favoriteFoods (you can use Array.push()). 
Then - inside the find callback - save() the updated Person.
Note: This may be tricky, if in your Schema, you declared favoriteFoods as an Array, 
without specifying the type (i.e. [String]). In that case, favoriteFoods defaults to Mixed type, 
and you have to manually mark it as edited using document.markModified('edited-field'). See Mongoose documentation
*/
const findEditThenSave = (personId, done) => {
  const foodToAdd = "hamburger";
  
  //find
  Person.findById({_id: personId}, (err, match) => {
    if(err) return console.log(err);
    
    //add fav food
      match.favoriteFoods.push(foodToAdd);

    //save and return upd obj
      match.save((err, updatedPerson) => {
        if(err) return console.log(err);
        done(null, updatedPerson);
      });
  });
};


/*
Perform New Updates on a Document Using model.findOneAndUpdate()

Recent versions of Mongoose have methods to simplify documents updating. 
Some more advanced features (i.e. pre/post hooks, validation) behave differently with this approach, 
so the classic method is still useful in many situations. findByIdAndUpdate() can be used when searching by id.
Modify the findAndUpdate function to find a person by Name and set the person's age to 20. 
Use the function parameter personName as the search key.
Note: You should return the updated document. To do that, you need to pass 
the options document { new: true } as the 3rd argument to findOneAndUpdate(). 
By default, these methods return the unmodified object.
*/

const findAndUpdate = (personName, done) => {
  const ageToSet = 20;

  Person.findOneAndUpdate({name: personName}, {age: ageToSet}, {new: true}, (err, match) => {
    if(err) return console.log(err);
    done(null, match);
  })
};

const removeById = (personId, done) => {
  done(null /*, data*/);
};

const removeManyPeople = (done) => {
  const nameToRemove = "Mary";

  done(null /*, data*/);
};

const queryChain = (done) => {
  const foodToSearch = "burrito";

  done(null /*, data*/);
};





/** **Well Done !!**
/* You completed these challenges, let's go celebrate !
 */

//----- **DO NOT EDIT BELOW THIS LINE** ----------------------------------

exports.PersonModel = Person;
exports.createAndSavePerson = createAndSavePerson;
exports.findPeopleByName = findPeopleByName;
exports.findOneByFood = findOneByFood;
exports.findPersonById = findPersonById;
exports.findEditThenSave = findEditThenSave;
exports.findAndUpdate = findAndUpdate;
exports.createManyPeople = createManyPeople;
exports.removeById = removeById;
exports.removeManyPeople = removeManyPeople;
exports.queryChain = queryChain;
