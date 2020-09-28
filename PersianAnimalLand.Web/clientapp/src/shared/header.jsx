import React from 'react'
import Logo from '../shared/logo'
import { Link } from 'react-router-dom';

const Header = () => {
    return (
        <>
            <div id="kt_header" className="header header-fixed header-menu">
                <div className="container d-flex align-items-stretch justify-content-between">
                    <div className="d-flex align-items-stretch mr-3">
                        <div className="header-logo">
                            <Logo />
                        </div>
                        <div className="header-menu-wrapper header-menu-wrapper-left" id="kt_header_menu_wrapper">
                            <div id="kt_header_menu" className="header-menu header-menu-left header-menu-mobile header-menu-layout-default">
                                <ul className="menu-nav">
                                    <li className="menu-item menu-item-submenu menu-item-open-dropdown" data-menu-toggle="click" aria-haspopup="true">
                                        <Link className="menu-link" to="/">Home</Link>
                                    </li>
                                    <li className="menu-item menu-item-submenu menu-item-open-dropdown" data-menu-toggle="click" aria-haspopup="true">
                                        <Link className="menu-link" to="/aboutus">Aboutus </Link>
                                    </li>
                                    <li className="menu-item menu-item-submenu menu-item-open-dropdown" data-menu-toggle="click" aria-haspopup="true">
                                        <Link className="nav-link" to="/store">Store</Link>
                                    </li>
                                    <li className="menu-item menu-item-submenu menu-item-open-dropdown" data-menu-toggle="click" aria-haspopup="true">
                                        <Link className="nav-link" to="/clinic">Clinic</Link>
                                    </li>
                                    <li className="menu-item menu-item-submenu menu-item-open-dropdown" data-menu-toggle="click" aria-haspopup="true">
                                        <Link className="nav-link" to="/contactus">Contact Us</Link>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
        
    )
}

export default Header;
