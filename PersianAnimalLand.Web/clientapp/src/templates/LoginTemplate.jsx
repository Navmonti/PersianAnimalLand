import React from 'react'; 
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom'; 
import Login from '../pages/login/login';

const LoginTemplate =() => {
    return (
        <Router> 
            <Switch> 
                <Route exact path='/login' component={Login} />
            </Switch> 
        </Router>
    );
}

export default LoginTemplate;
