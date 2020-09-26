import React from 'react';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import MainTemplate from './templates/MainTemplate';
import PanelTemplate from './templates/PanelTemplate';
import LoginTemplate from './templates/LoginTemplate';
import UserTemplate from './templates/UserTemplate';
import MemberTemplate from './templates/MemberTemplate';


function App() {
    return (
        <Router>
            <Switch>
                <Route exact path='/' component={MainTemplate} />
                <Route exact path='/Panel' component={PanelTemplate} />
                <Route exact path='/Member' component={MemberTemplate} />
                <Route exact path='/User' component={UserTemplate} />
                <Route exact path='/Login' component={LoginTemplate} />
            </Switch>
        </Router>
    );
}

export default App;
