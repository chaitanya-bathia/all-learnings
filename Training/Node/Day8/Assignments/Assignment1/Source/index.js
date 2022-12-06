var express = require('express');
const jwt = require('jsonwebtoken');
global.config = require('./config');
var router = express.Router();
var app = express();
app.use(express.json());
router.get('/', function (req, res, next) {
  res.send('respond with a resource');
});

router.post('/login', (req, res, next) => {
  let userdata = {
    username: req.body.username,
    password: req.body.password,
  };
  let token = jwt.sign(userdata, global.config.secretKey, {
    algorithm: global.config.algorithm,
    expiresIn: '5m',
  });
  if (userdata.username == 'admin' && userdata.password == 'admin') {
    res.status(200).json({
      message: 'Login Successful',
      jwtoken: token,
    });
  } else {
    res.status(401).json({
      message: 'Login Failed',
    });
  }
});

var verifyToken = (req, res, next) => {
  var token = req.headers['x-access-token'];
  if (!token) {
    return res.status(500).json({ success: false, message: 'Pass Token' });
  }
  jwt.verify(
    token,
    global.config.secretKey,
    {
      algorithm: global.config.algorithm,
    },
    (err, decoded) => {
      if (err) {
        return res.status(401).json({
          message: 'Unauthorized Access',
        });
      }
      console.log(decoded);
      next();
    }
  );
};
// result list without protection
router.get('/result', verifyToken, (req, res, next) => {
  let result = [
    {
      ID: 1,
      Hindi: 80,
      Gujarati: 60,
      Eng: 85,
      Math: 68,
      Science: 75,
    },
    {
      ID: 2,
      Hindi: 70,
      Gujarati: 50,
      Eng: 76,
      Math: 63,
      Science: 70,
    },
    {
      ID: 3,
      Hindi: 56,
      Gujarati: 66,
      Eng: 75,
      Math: 59,
      Science: 60,
    },
    {
      ID: 4,
      Hindi: 90,
      Gujarati: 85,
      Eng: 85,
      Math: 82,
      Science: 81,
    },
    {
      ID: 5,
      Hindi: 76,
      Gujarati: 60,
      Eng: 70,
      Math: 68,
      Science: 72,
    },
    {
      ID: 6,
      Hindi: 65,
      Gujarati: 76,
      Eng: 75,
      Math: 69,
      Science: 65,
    },
  ];
  res.json(result);
  next();
});
// Fees list without protection
router.get('/fees', verifyToken, (req, res, next) => {
  let fees = [
    {
      ID: 1,
      Amount: 10000,
      status: 'Paid',
    },
    {
      ID: 2,
      Amount: 25000,
      status: 'Paid',
    },
    {
      ID: 3,
      Amount: 20000,
      status: 'UnPaid',
    },
    {
      ID: 4,
      Amount: 15000,
      status: 'Unpaid',
    },
    {
      ID: 5,
      Amount: 19000,
      status: 'Paid',
    },
    {
      ID: 6,
      Amount: 15000,
      status: 'UnPaid',
    },
  ];
  res.json(fees);
  next();
});
app.use('/', router);
app.listen(3000,()=>{
    console.log("Server running...");
});
