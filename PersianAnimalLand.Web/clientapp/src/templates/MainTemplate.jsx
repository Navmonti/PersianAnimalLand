import React from 'react';
import Header from '../shared/header';
import Footer from '../shared/footer';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import AboutUs from '../pages/main/aboutus';
import ContactUs from '../pages/main/contactus';
import Home from '../pages/main/home';
import MobileHeader from '../shared/mobileheader';

const MainTemplate = () => {
    return (
        <Router>
            <MobileHeader />
            <div className="d-flex flex-column flex-root">
                <div className="d-flex flex-row flex-column-fluid page">
                    <div className="d-flex flex-column flex-row-fluid wrapper" id="kt_wrapper">
                        <Header />
                        <div className="content d-flex flex-column flex-column-fluid">
                            <div className="d-flex flex-column-fluid">
                                <Switch>
                                    <Route exact path='/' component={Home} />
                                    <Route path='/contactus' component={ContactUs} />
                                    <Route path='/aboutus' component={AboutUs} />
                                </Switch>
                            </div>
                        </div>
                        <Footer />
                    </div>
                </div>
            </div>
            
        </Router>
    );
}

export default MainTemplate;
