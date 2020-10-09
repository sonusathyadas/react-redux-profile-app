import React from "react";
import {
    BrowserRouter as Router,
    Switch,
    Route
} from "react-router-dom";
import { About } from './components/About';
import { TopNav } from './components/TopNav';
import { NotFound } from './components/Notfound';
import ProfileList  from "./containers/ProfileList";
import AddProfile from "./containers/AddProfile";


export default function App() {
    return (
        <Router>
            <TopNav />
            <div className='container'>
                <Switch>
                    <Route exact path='/'>
                        <ProfileList />
                    </Route>
                    <Route path='/add'>
                        <AddProfile/>
                    </Route>
                    <Route path='/about'>
                        <About />
                    </Route>
                    <Route path="*">
                        <NotFound />
                    </Route>
                </Switch>
            </div>
        </Router>
    );
}
