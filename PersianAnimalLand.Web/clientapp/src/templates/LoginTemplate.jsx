import React from 'react'; 
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom'; 
import Login from '../pages/login';

function LoginTemplate() {
    return (
        <Router> 
            <Switch> 
                <Route path='/login' component={Login} />
            </Switch> 
        </Router>
    );
}

export default LoginTemplate;
