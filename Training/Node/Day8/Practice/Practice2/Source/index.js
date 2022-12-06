var express = require('express');
var router = express.Router();
global.config = require('./config');
let app = express();
app.use(express.json());
let jwt = require('jsonwebtoken');
router.use(function (req, res, next) {
  console.log(`Request Type: ${req.method}`);
  next();
});
app.get('/login', (req, res) => {
  res.send('Hello All');
});

router.post('/login', (req, res) => {
  userdata = {
    username: req.body.username,
    password: req.body.password,
  };
  let token = jwt.sign(userdata, global.config.secretKey, {
    algorithm: global.config.algorithm,
    expiresIn: '5m',
  });
  if (userdata.username === 'admin' && userdata.password === 'admin') {
    res.status(200).json({
      message: 'Login Successful',
      jwtoken: token,
    });
  } else {
    res.status(401).json({
      message: 'Login Faild',
    });
  }
});
app.listen(3001, () => {
  console.log('3000 port Runnung......');
});
app.use('/', router);
