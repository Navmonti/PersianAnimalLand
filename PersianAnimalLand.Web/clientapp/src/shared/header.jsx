import React from 'react'
import Logo from '../shared/logo'
import { Link } from 'react-router-dom';

const Header = () => {
    return (
        <header className="App-header">
            <nav className="navbar navbar-expand-lg header-menu">
                <Logo />
                <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span className="navbar-toggler-icon"></span>
                </button>
                <div className="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul className="navbar-nav mr-auto">
                        <li className="nav-item header-menu-item ">
                            <Link className="nav-link" to="/">Home</Link>
                        </li>
                        <li className="nav-item header-menu-item ">
                            <Link className="nav-link" to="/aboutus">About US</Link>
                        </li>
                        <li className="nav-item header-menu-item ">
                            <Link className="nav-link" to="/">Store</Link>
                        </li>
                        <li className="nav-item header-menu-item ">
                            <Link className="nav-link" to="/">Clinic</Link>
                        </li>
                        <li className="nav-item header-menu-item ">
                            <Link className="nav-link" to="/contactus">Contact Us</Link>
                        </li>
                    </ul>
                </div>
                <div className="pull-right">
                    <Link className="nav-link" to="/login">Login</Link>
                </div>
            </nav>
        </header>
    )
}

export default Header;
