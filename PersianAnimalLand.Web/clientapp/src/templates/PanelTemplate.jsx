import React from 'react'; 
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';  
import Login from '../pages/login/login';
import Dashboard from '../pages/panel/dashboard';

const PanelTemplate =() =>{
    return (
        <Router> 
            <Switch>
                <Route exact path='/panel' component={Dashboard} /> 
            </Switch> 
        </Router>
    );
}

export default PanelTemplate;
