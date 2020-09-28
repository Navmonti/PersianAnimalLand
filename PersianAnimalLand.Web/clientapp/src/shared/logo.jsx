import React from 'react';
import LogoUr from '../image/Logo.png';

const Logo = () => {
    return (
        <a className="navbar-brand" href="#">
            <img className="Logo" src={LogoUr}/>
        </a>
    )
}

export default Logo;
