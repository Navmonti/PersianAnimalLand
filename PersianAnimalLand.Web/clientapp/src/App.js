import React from 'react'; 
import Header from './shared/header';
import Footer from './shared/footer';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import AboutUs from './pages/aboutus';
import ContactUs from './pages/contactus';
import Home from './pages/home';
import Login from './pages/login';

function App() {
  return ( 
      <Router>
          <div>
              <Header /> 
              <Switch>
                  <Route exact path='/' component={Home} />
                  <Route path='/contactus' component={ContactUs} />
                  <Route path='/aboutus' component={AboutUs} />
                  <Route path='/login' component={Login} />
              </Switch>
              <Footer /> 
          </div>
      </Router>
  );
}

export default App;
