import React, {Component} from 'react';
import '../App.css';

export class Header extends Component
{
    render()
    {
        return(
            <div className='header'>
                <button className='headerButton'>Home</button>
                <button className='headerButton'>About</button>
            </div>
        )
    }
}