import React, { Component} from 'react';
import PropTypes from 'prop-types';
//import logo from './logo.svg';
//import './assets/css/bootstrap.min.css';

//Component
import Content from './componentes/Global/Content';
import $ from 'jquery';
import 'bootstrap/dist/js/bootstrap.bundle.min';

class App extends Component {
  static propTypes = {
    children: PropTypes.object.isRequired
  };

  render() {
    const { children } = this.props;

    return (

        <Content body={children} />

    );
  }
}


export default App;
