//Dependecies
import React from 'react';
import {Route, Router, Switch} from 'react-router';


//Components
import App from './App';
import Login from './views/login';
import Dashboard from './views/dashboard';
import Inventario from './views/inventario';


const AppRoutes =()=>
    <App>
        <Switch>
            <Route  exact path='/'  component={Login} />
            <Route  exact path='/vipermedix/'  component={Dashboard} />
            <Route exact path="/vipermedix/inventario" component={Inventario}/>
        </Switch>
    </App>;

    export default AppRoutes;
