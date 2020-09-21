﻿import React from 'react';
import dogImage from '../image/cat.png';
import catImage from '../image/dog.png';

const ContactUs = () => {
    return (
        <footer className="container-fluid text-center footer ">
            <div className="row">
                <div className="col-md-3 text-center">
                    <img src={dogImage} width="50%" />
                </div>
                <div className="col-md-3 text-center">
                    <ul>
                        <li>Item 1</li>
                        <li>Item 2</li>
                        <li>Item 3</li>
                        <li>Item 4</li>
                    </ul>
                </div>
                <div className="col-md-3 text-center">
                    <ul>
                        <li>Item 1</li>
                        <li>Item 2</li>
                        <li>Item 3</li>
                        <li>Item 4</li>
                    </ul>
                </div>
                <div className="col-md-3 text-center">
                    <img src={catImage} width="50%" />
                </div>
            </div>

        </footer>
    )
}

export default ContactUs;