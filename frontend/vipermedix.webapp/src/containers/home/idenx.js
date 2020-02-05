//Dependencies
import React, {Component} from  'react';
import {connect} from 'react-redux';
import PropTypes from 'prop-types';

class Home extends Component {

    static propTypes = {
        isMobile:PropTypes.bool
    };

    render(){
        return(
            <div className="container-fluid">
                <h1>Hola Mundos</h1>
            </div>
        );
    }

}

export default connect(state =>({
    isMobile: state.device.isMobile
}),null)(Home);