import React from 'react';
import LogoUr from '../image/Logo.png';

const Logo = () => {
    return (
        <a className="navbar-brand" href="#">
            <img className="Logo pt-md pb-md" src={LogoUr} />
        </a>
    )
}

export default Logo;
