//Dependecies
import React from 'react';
import {Link, Route, Router, Switch} from 'react-router';


//Components
import App from './App';
import Almacen from './componentes/views/almacen';

const AppRoutes =()=>
    <App>
        <Switch>
            <Route exact path="/vipermedix/almacen" component={Almacen}/>
        </Switch>
    </App>;

    export default AppRoutes;
