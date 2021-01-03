// server.js
// where your node app starts

// init project
var express = require('express');
var app = express();

// enable CORS (https://en.wikipedia.org/wiki/Cross-origin_resource_sharing)
// so that your API is remotely testable by FCC 
var cors = require('cors');
app.use(cors({optionsSuccessStatus: 200}));  // some legacy browsers choke on 204

// http://expressjs.com/en/starter/static-files.html
app.use(express.static('public'));

// http://expressjs.com/en/starter/basic-routing.html
app.get("/", function (req, res) {
  res.sendFile(__dirname + '/views/index.html');
});


// your first API endpoint... 
app.get("/api/hello", function (req, res) {
  res.json({greeting: 'hello API'});
});



// listen for requests :)
var listener = app.listen(process.env.PORT, function () {
  console.log('Your app is listening on port ' + listener.address().port);
});


// api request with date string
app.get('/api/timestamp/:date', (req, res) => {
  
  let dateString = req.params.date;
  
  //5 digits or more must be a unix time
  
  if(/\d{5,}/.test(dateString)){
    // The parseInt() function parses a string argument and returns an integer
    var dateFormat = parseInt(dateString);
    //Date.prototype.toUTCString() Converts a date to a string using the UTC timezone.
    res.json({unix: dateString, utc: new Date(dateFormat).toUTCString()});
  }
  
  var dateFormat2 = new Date(dateString);
  
  if(dateFormat2.toString() === 'Invalid Date'){
    res.json({ error : "Invalid Date" });
  }else{
    res.json({unix: dateFormat2.valueOf(), utc: dateFormat2.toUTCString()});
  }
      
});

// api request with no params
app.get('/api/timestamp/', (req, res) => {
  
    var dateNow = new Date();
    res.json({unix: dateNow.valueOf(), utc: dateNow.toUTCString()});
});