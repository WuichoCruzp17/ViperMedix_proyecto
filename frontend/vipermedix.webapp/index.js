import React from 'react';
import ReactDOM from 'react-dom';
import {render} from 'react-dom';
import {BrowserRouter  as Router} from 'react-router-dom';
import {Provider} from 'react-redux';
import './index.css';
/* import App from './App';
import * as serviceWorker from './serviceWorker'; */

//Routes
import AppRoutes from './routes';

//Assets
import 'bootstrap/dist/css/bootstrap.min.css';

//Redux store
//import configureSotre from './lib/configureSotre'

//Reducers
//import rooReducer from './reducers';
import Bluebird from 'bluebird';
//import rootReducer from './reducers';

//Bluebird configuration
window.Promise = Bluebird;

Bluebird.config({warnings:false});

window.addEventListener('unhandledrejection',error=>{
    error.preventDefault();
    if(process.env.NODE_ENV !== 'production'){
        console.warn('Unhandled promise rejection warning.', error.detail);
    }
});

// Configure redux store
/* const store = configureSotre({
    initialState:window.initialState
}, rootReducer); */

render(
        <Router>
            <AppRoutes />
        </Router>
    ,
    document.getElementById('root')

);
//ReactDOM.render(<App />, document.getElementById('root'));


//serviceWorker.unregister();
