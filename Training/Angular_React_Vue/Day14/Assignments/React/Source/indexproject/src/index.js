import React from 'react';
import {BrowserRouter,Routes,Route} from 'react-router-dom';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

import HTML from './routes/Html';
import CSS from './routes/Css';
import JavaScript from './routes/Javascript';
import HTMLDay1 from './routes/HtmlDay1';
import HTMLDay2 from './routes/HtmlDay2';
import CssDay1 from './routes/CssDay1';
import CssDay2 from './routes/CssDay2';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <BrowserRouter>
  <Routes>
    <Route path='/' element={<App/>}>
      <Route path='/html' element={<HTML />}>
        <Route path='day1' element={<HTMLDay1/>}></Route>
        <Route path='day2' element={<HTMLDay2/>}></Route>
      </Route>
      <Route path='/css' element={<CSS />}>
        <Route path="day1" element={<CssDay1/>}></Route>
        <Route path='day2' element={<CssDay2/>}></Route>
      </Route>
      <Route path='/js' element={<JavaScript />}></Route>
    </Route>
  </Routes>
  </BrowserRouter>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
