var express = require('express');
var mongo = require('mongodb');
var dns = require('dns');
var url = require('url');
var bodyParser = require('body-parser');
var cors = require('cors');

var app = express();

// Basic Configuration 
var port = process.env.PORT;

/** this project needs a db !! **/ 
var mongoose = require('mongoose');
const AutoIncrement = require('mongoose-sequence')(mongoose);
mongoose.connect(process.env.MONGO_URI, {useNewUrlParser: true, useUnifiedTopology: true, useFindAndModify: false, useCreateIndex: true});

app.use(cors());

/** this project needs to parse POST bodies **/
// you should mount the body-parser here
app.use(bodyParser.urlencoded({extended: false}));
app.use('/public', express.static(process.cwd() + '/public'));

app.get('/', function(req, res){
  res.sendFile(process.cwd() + '/views/index.html');
});

  
// your first API endpoint... 
app.get("/api/hello", function (req, res) {
  res.json({greeting: 'hello API'});
});

var Schema = mongoose.Schema;
var urlSchema = new Schema({
  original_url: {type: String, required: true }
});

urlSchema.plugin(AutoIncrement, {inc_field: 'short_url'});
var ShortURL = mongoose.model('ShortURL', urlSchema);


//redirect to original url
app.get('/api/shorturl/:short_url', (req, res) => {
  var num= req.params.short_url;
  ShortURL.findOne({"short_url": num}, (err, data) => {
    if(err) res.json({error: 'No URL found'});
    console.log('response: '+data);
    res.redirect(data.original_url);
  });
});


// save new url posted
app.post("/api/shorturl/new", function (req, res, next) {
  const host = url.parse(req.body.url);
  //test if url points to valid server
  dns.lookup(host.hostname, async function(err, addresses, family) {
    if(addresses) {
      var newURL = new ShortURL({original_url: 'https://'+host.hostname});
      newURL.save(function(err, data){
        console.log('data',data);
        return res.json({original_url: req.body.url, short_url: data.short_url});
      })
    }
    else res.json({error: 'invalid URL'});
  });
});


app.listen(port, function () {
  console.log('Node.js listening ...');
});
