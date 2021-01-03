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
  Person.find({name: personName}, function(err, match){
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
  Person.findOne({favoriteFoods: food}, function(err, match){
      if(err) return console.log(err);
      done(null, match);
  });
};

const findPersonById = (personId, done) => {
  done(null /*, data*/);
};

const findEditThenSave = (personId, done) => {
  const foodToAdd = "hamburger";

  done(null /*, data*/);
};

const findAndUpdate = (personName, done) => {
  const ageToSet = 20;

  done(null /*, data*/);
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
