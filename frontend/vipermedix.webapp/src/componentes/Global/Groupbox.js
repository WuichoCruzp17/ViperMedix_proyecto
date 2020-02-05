//Dependencies
import React, {Component} from 'react';
import PropTypes from 'prop-types';

import '../../assets/css/groupbox.css';
class GroupBox extends Component{

    constructor(props){
        super(props);
        this.state={
            legend:PropTypes.string,
            cont:PropTypes.object
        }
    }

    render(){
        return(
            <fieldset className="well">
                <legend className="well-legend text-uppercase">{this.props.legend}</legend>
               {this.props.conten}
            </fieldset>
        ); 
    }

}

export default GroupBox;