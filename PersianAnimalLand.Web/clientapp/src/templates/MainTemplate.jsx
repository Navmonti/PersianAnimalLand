import React from 'react';
import Header from '../shared/header';
import Footer from '../shared/footer';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import AboutUs from '../pages/aboutus';
import ContactUs from '../pages/contactus';
import Home from '../pages/home'; 

function MainTemplate() {
    return (
        <Router>
            <Header />
            <Switch>
                <Route exact path='/' component={Home} /> 
                <Route path='/contactus' component={ContactUs} />
                <Route path='/aboutus' component={AboutUs} /> 
            </Switch>
            <Footer />
        </Router>
    );
}

export default MainTemplate;
