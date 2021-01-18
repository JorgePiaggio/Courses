const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const personSchema = new Schema ({
  name: {type: String, required: true},
  surname: {type: String, required: true},
  age: Number,
  favoriteFoods: [String],
  country: String
});


module.exports = personSchema;
