const express = require('express')
const app = express()
const cors = require('cors')
require('dotenv').config()


const bodyParser = require('body-parser')
app.use(bodyParser.urlencoded({extended: false}))
app.use(bodyParser.json())


app.use(cors())
app.use(express.static('public'))
app.get('/', (req, res) => {
  res.sendFile(__dirname + '/views/index.html')
});


// db setup
const mongoose = require('mongoose');
var port = process.env.PORT || 3000; 

mongoose.connect(process.env.DB_URI,{
  useNewUrlParser: true,
  useUnifiedTopology: true
});

// schema 1 : users
const UserSchema = new mongoose.Schema({
  username: { type: String, required: true, unique: true}
});
const ExerciseUser = mongoose.model("ExerciseUser", UserSchema);

// schema 2 : exercises
const exerciseSchema = new mongoose.Schema({
  userId: { type: String, required: true },
  description: { type: String, required: true },
  duration: { type: Number, required: true },
  date: { type: Date, required: true, default: Date.now }
});
const Exercise = mongoose.model("Exercise", exerciseSchema);

/*////////////////////////////////////////////////////////////////////////////////
Asynchronous programming in Node.js

Asynchronous I/O is a form of input/output processing that permits other processing 
to continue before the transmission has finished.
/*////////////////////////////////////////////////////////////////////////////////



/*
You can POST to /api/exercise/new-user with form data username to create a new user. 
The returned response will be an object with username and _id properties.
*/
app.post('/api/exercise/new-user', async (req, res) => {
  try{
    const name = req.body.username;
    if(!name) {
      throw new Error("Username not provided");
    }
    const user = new ExerciseUser({ username: name});
    await user.save().then( u => {
      res.send({username: u.username,
              _id: u._id
             });
          });
  }catch (e) {
    res.send({
      error: e.message
    });
  }
})


/*
You can make a GET request to api/exercise/users to get an array of all users. 
Each element in the array is an object containing a user's username and _id.
*/
app.get('/api/exercise/users', async (req, res) => {
    try{
      const users = await ExerciseUser.find();
      res.send(users);
    } catch (e) {
    res.send({
      error: e.message
    });
  }
});


// get user id by submitting the name
app.post('/api/exercise/userid', async (req, res) => {
    try{
      const username = req.body.find;
      if(!req.body.find) {
        throw new Error("Please enter user name");
      }
      const user = await ExerciseUser.find({'username':username})
      res.send(user);
    } catch (e) {
    res.send({
      error: e.message
    });
  }
});


/*
You can POST to /api/exercise/add with form data userId=_id, description, duration, and optionally date. 
If no date is supplied, the current date will be used. 
The response returned will be the user object with the exercise fields added.
*/

app.post('/api/exercise/add', async (req, res) => {
  try {
    // Check required fields.
    if (!req.body.userId || !req.body.description || !req.body.duration) {
      throw new Error("Please complete required fields");
    }
    if (isNaN(req.body.duration)) {
      throw new Error("Duration should be a number.");
    }
    const user = await ExerciseUser.findById(req.body.userId);
    if (!user) {
      throw new Error("User not found. Please add the user before submitting exercises");
    }
    const exercise = new Exercise({
      userId: user._id,
      description: req.body.description,
      duration: Number.parseFloat(req.body.duration),
      date: req.body.date ? new Date(req.body.date) : undefined
    });
    await exercise.save().then(u => {
      res.send({
        _id: user._id,
        username: user.username,
        description: u.description,
        duration: u.duration,
        date: u.date.toDateString()
      });
    });
  } catch (e) {
    res.send({
      error: e.message
    });
  }
});


/*
You can make a GET request to /api/exercise/log with a parameter of userId=_id to retrieve a full exercise log of any user. 
The returned response will be the user object with a log array of all the exercises added. 
Each log item has the description, duration, and date properties.
*/

app.get('/api/exercise/log', async (req, res) => {
  try {
    const { userId, from, to, limit } = req.query;
    if (!userId) {
      throw new Error("Missing userId");
    }
    if (from && isNaN(new Date(from)) || to && isNaN(new Date(to))) {
      throw new Error("Invalid date");
    }
    if (limit && isNaN(limit)) {
      throw new Error("Limit is not a number");
    }

    const user = await ExerciseUser.findById(userId);
    if (!user) {
      throw new Error("User not found");
    }

    let query = Exercise.find({ userId: user._id });
    if (from) {
      query = query.where("date").gt(new Date(from));
    }
    if (from) {
      query = query.where("date").lt(new Date(to));
    }
    if (limit) {
      query = query.limit(Number.parseInt(limit));
    }
    query = query.select({
      _id: 0,
      description: 1,
      duration: 1,
      date: 1
    });
    const log = await query.exec();
    res.send({
      _id: user._id,
      username: user.username,
      log,
      count: log.length
    });
  } catch (e) {
    res.send({
      error: e.message
    });
  }
});



const listener = app.listen(process.env.PORT || 3000, () => {
  console.log('Your app is listening on port ' + listener.address().port)
})
