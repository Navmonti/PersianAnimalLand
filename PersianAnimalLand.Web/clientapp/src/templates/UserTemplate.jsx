import React from 'react';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Login from '../pages/login/login';
import User from '../pages/user/user';

const UserTemplate = () => {
    return (
        <Router>
            <Switch>
                <Route exact path='/user' component={User} />
            </Switch>
        </Router>
    );
}

export default UserTemplate;
