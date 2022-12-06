import React, { Component } from 'react';
import '../App.css';
import { About } from './About';
import { Home } from './Home';

export class Section extends Component {
    render() {
        return (
            <div>
                <Home></Home>
                <About></About>
            </div>
        )
    }
}