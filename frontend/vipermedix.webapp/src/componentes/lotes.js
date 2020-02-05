import React, {Component} from 'react';

//Components
import {Form, Card} from 'react-bootstrap';

class Lote extends Component {

    constructor(props){
        super(props);
        this.state={

        }
    }

    
    render(){
        {
                return(
                    <div className="col-sm-12">
                        <Card body>
                            <div className="row">
                                <div className="col-sm-4 text-center">
                                    <Form.Check type="checkbox" label={this.props.numLote}></Form.Check>
                                </div>
                                <div className="col-sm-4 text-center">
                                    {this.props.cantidad}
                                </div>
                                <div className="col-sm-4 text-center">
                                    {this.props.fechaCaducidad}
                                </div>
                            </div>
                        </Card>
                    </div>
                );
        }
    }

}

export default Lote;