import React from 'react';
import Header from '../shared/header';
import Footer from '../shared/footer';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import AboutUs from '../pages/main/aboutus';
import ContactUs from '../pages/main/contactus';
import Home from '../pages/main/home'; 

const MainTemplate = () => {
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
