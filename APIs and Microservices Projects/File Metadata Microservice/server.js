var express = require('express');
var cors = require('cors');
var multer = require('multer');  //middleware designed for handling the multipart/form-data // https://www.npmjs.com/package/multer
require('dotenv').config()

var app = express();

app.use(cors());
app.use('/public', express.static(process.cwd() + '/public'));
app.use(multer().single('upfile'));// upfile => input name

app.get('/', function (req, res) {
    res.sendFile(process.cwd() + '/views/index.html');
});


app.post('/api/fileanalyse', (req, res) => {
  console.log(req.file);
  res.send({
    name: req.file.originalname,
    type: req.file.mimetype,
    size: req.file.size,
    encoding: req.file.encoding
  });
})

const port = process.env.PORT || 3000;
app.listen(port, function () {
  console.log('Your app is listening on port ' + port)
});
