import React from 'react';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Member from '../pages/member/member';

const Memberemplate = () => {
    return (
        <Router>
            <Switch>
                <Route exact path='/member' component={Member} />
            </Switch>
        </Router>
    );
}

export default Memberemplate;
