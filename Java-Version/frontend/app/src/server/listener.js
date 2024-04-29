const express = require('express');
const app = express();
const port = process.env.PORT || 5000;
const bodyParser = require('body-parser');
const React = require("react");
const axios = require("axios");

app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

app.listen(port, () => console.log(`Listening on port ${port}`));

const URL = 'http://localhost:8080/api/3enrayas';

app.post('/check-winner', (req, res) => {
  try {
    const { icon, places } = req.body;
    const headers = {
      'Content-Type': 'application/json',
    };

    axios.post(URL+'/winner?icon='+icon, places, { headers })
      .then(response => {
        res.send(response.data);
      })
      .catch(error => {
        console.error(error);
        res.status(500).send('Internal Server Error');
      });
  } catch (err) {
    console.error(err);
    res.status(500).send({ error: 'Something went wrong' });
  }
});

app.post('/empty-position', (req, res) => {
  try {
    const { icon, places } = req.body;
    const headers = {
      'Content-Type': 'application/json',
    };

    axios.post(URL+'/iaplay?icon='+icon, places, { headers })
      .then(response => {
        res.send(response.data);
      })
      .catch(error => {
        console.error(error);
        res.status(500).send('Internal Server Error');
      });
  } catch (err) {
    console.error(err);
    res.status(500).send({ error: 'Something went wrong' });
  }
});

app.post('/check-time', (req, res) => {
  try {
    let { seconds } = req.body; // Use "let" instead of "const" to allow reassignment
    const headers = {
      'Content-Type': 'plain/text',
    };

    seconds = seconds.toString().replace("data:", "");

    axios.post(URL+'/duration', seconds, { headers })
      .then(response => {
        res.send(response.data);
      })
      .catch(error => {
        console.error(error);
        res.status(500).send('Internal Server Error');
      });
  } catch (err) {
    console.error(err);
    res.status(500).send({ error: 'Something went wrong' });
  }
});

