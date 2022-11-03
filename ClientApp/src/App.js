import React, { Component } from 'react';
import { Route, Redirect, Switch } from "react-router-dom";
import Translator from './components/Translator';
import NotFound from './components/NotFound'
import NavBar from "./components/navBar";
import './custom.css'

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <React.Fragment>
                <NavBar />
                <main className="container">
                    <Switch>
                        <Route exact path='/' component={Translator} />
                        <Route exact path='/translator' component={Translator} />
                        <Route path="/not-found" component={NotFound} />
                        <Redirect to="/not-found" />
                    </Switch>
                </main>
            </React.Fragment>
        );
    }
}
