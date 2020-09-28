import React from 'react'
import Logo from '../shared/logo'
import { Link } from 'react-router-dom';

const Header = () => {
    return (
        <div id="kt_header" class="header header-fixed header-menu">
            <div class="container-fluid d-flex align-items-stretch justify-content-between">
                <div class="d-flex align-items-stretch mr-3">
                    <div class="header-logo">
                        <a href="/metronic/demo2/index.html">
                            <Logo/>
                        </a>
                    </div>
                    <div class="header-menu-wrapper header-menu-wrapper-left" id="kt_header_menu_wrapper">
                        <div id="kt_header_menu" class="header-menu header-menu-left header-menu-mobile header-menu-layout-default">
                            <ul class="menu-nav">
                                <li class="menu-item menu-item-open menu-item-here menu-item-submenu menu-item-rel menu-item-open menu-item-here" data-menu-toggle="click" aria-haspopup="true">
                                    <Link className="menu-link menu-toggle" to="/">Home</Link>
                                </li>
                                <li class="menu-item menu-item-submenu menu-item-open-dropdown" data-menu-toggle="click" aria-haspopup="true">
                                    <Link className="nav-link" to="/">Store</Link>
                                </li>
                                <li class="menu-item menu-item-submenu menu-item-open-dropdown" data-menu-toggle="click" aria-haspopup="true">
                                    <Link className="nav-link" to="/">Clinic</Link>
                                </li> 
                                <li class="menu-item menu-item-submenu menu-item-open-dropdown" data-menu-toggle="click" aria-haspopup="true">
                                    <Link className="nav-link" to="/contactus">Contact Us</Link>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Header;
