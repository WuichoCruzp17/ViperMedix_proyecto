//Dependencies
import React, {Component} from 'react';

//Utils
import  {inventario as inv, global} from '../utils/propertis';
import {formUtil} from '../utils/util';

//Services
import ProductService from '../services/ProductService';

//Imgs
import def from '../assets/img/default.PNG';

//Components
import GroupBox from '../componentes/Global/Groupbox';
import ModalForms from '../componentes/ModalForms';
import {ButtonGroup, Button} from 'react-bootstrap';
import Lote from '../componentes/lotes';
class Inventario extends Component{

    constructor(props){
        super(props);
        this.state = {
            show:false,
            lote:{
                numLote:0,
                cantidad:0,
                fechaCaducidad:new Date()
            },
            lotes:[]
        };
        this.handleShow = this.handleShow.bind(this);
        this.handleClose = this.handleClose.bind(this);
        
    }

    handleClose(){
        this.setState({show:false});
    }

    handleShow($){
        this.setState({show:true});
    }

    async getProduct(){
        var result=[];
        console.log(inv);
        try{

            if(document.getElementsByName(inv.frm_sucu)[0].value !==""){
                var e =0;
                console.log(e);    
            }else if(document.getElementsByName(inv.frm_codiB)[0].value!==""){
               result  = await ProductService.getProduct('L2',0,0,document.getElementsByName(inv.frm_codiB)[0].value);
            }
            formUtil.printForm(inv.frm_name,result[0]);

        }catch(err){
            console.log(err);
        }
        
    }

    render(){
        return(
            
        <React.Fragment>
            <div className="row mtop-10">
                <div className="col-sm-12">
                 <GroupBox legend="Busqueda Por:" conten={
                <div>
                    <div className="row">
                        <div className="col-sm-2 text-uppercase">{inv.key_sucu}:</div>
                            <div className="col-sm-6">
                                <select className="form-control" name={inv.frm_sucu}></select>
                            </div>
                        </div>
                    <div className="row" style={{marginTop:'10px'}}>
                        <div className="col-sm-2 text-uppercase">{inv.key_codiB}:</div>
                            <div className="col-sm-6">
                                <input type="text" className="form-control" name={inv.frm_codiB}/>
                            </div>
                            <div className="col-sm-2">
                                <button type="button" className="btn btn-success" onClick={this.getProduct}>{global.key_bus}</button>
                            </div>
                    </div>
                </div>        
                }>
                 </GroupBox>
                </div>
            </div>
            <form name={inv.frm_name}>
            <div className="row">
                <div className="col-sm-12">
                <GroupBox legend="Datos del Producto:" conten={
                    <div className="row">
                       <div className="col-sm-12">
                            <div className="row">
                                <div className="col-sm-6">
                                    <div className="row">
                                        <div className="col-sm-4 text-uppercase">
                                           {inv.key_susA}:
                                        </div>
                                        <div className="col-sm-7">
                                            <textarea className="form-control" name={inv.frm_susA}></textarea>
                                        </div>
                                        <div className="col-sm-4 text-uppercase" style={{marginTop:'10px'}}>
                                           {inv.key_desc}:
                                        </div>
                                        <div className="col-sm-7" style={{marginTop:'10px'}}>
                                            <textarea className="form-control" name={inv.frm_desc}></textarea>
                                        </div>
                                        <div className="col-sm-12 text-uppercase" style={{marginTop:'10px'}}>
                                           <div className="row">
                                              <div className="col-sm-4">
                                                {inv.key_preC}:
                                              </div>
                                              <div className="col-sm-5">
                                                <input type="text" className="form-control" name={inv.frm_preC}></input>
                                              </div> 
                                           </div>
                                        </div>
                                        <div className="col-sm-12">
                                            <div className="row">
                                                <div className="col-sm-4 text-uppercase" style={{marginTop:'10px'}}>
                                                    {inv.key_preP}:
                                                </div>
                                                <div className="col-sm-5" style={{marginTop:'10px'}}>
                                                    <input type="text" className="form-control" disabled name={inv.frm_preP}></input>
                                                </div>
                                            </div>
                                        </div>
                                        <div className="col-sm-4 text-uppercase" style={{marginTop:'10px'}}>
                                            {inv.key_ubi}
                                        </div>
                                        <div className="col-sm-7" style={{marginTop:'10px'}}>
                                            <input type="text" className="form-control" name={inv.frm_ubi}></input>
                                        </div>
                                        <div className="col-sm-4 text-uppercase" style={{marginTop:'10px'}}>
                                            {inv.key_pro}
                                        </div>
                                        <div className="col-sm-7" style={{marginTop:'10px'}}>
                                            <select className="form-control" name={inv.frm_pro}></select>
                                        </div>
                                        <div className="col-sm-12">
                                            <div className="row">
                                                <div className="col-sm-3 offset-sm-4">
                                                    <div className="form-check form-check-inline">
                                                        <input type="checkbox" className="form-check-input" name={inv.frm_cad}></input>
                                                        <label className="form-check-label text-uppercase">{inv.key_cad}</label>
                                                    </div>
                                                </div>
                                                <div className="col-sm-3 offset-sm-1">
                                                    <div className="form-check form-check-inline">
                                                        <input type="checkbox" className="form-check-input" name={inv.frm_anti}></input>
                                                        <label className="form-check-label text-uppercase">{inv.key_anti}</label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div> 
                                <div className="col-sm-6">
                                    <div className="text-center">
                                        <img src={def} className="img-fluid"  style={{height:'200px', width:'70%'}}></img>
                                    </div>
                                    <div className="row">
                                        <div className="col-sm-12">
                                            <div className="row">
                                                <div className="col-sm-4 offset-sm-1">
                                                    <div className="row">
                                                        <div className="col-sm-12 text-uppercase">
                                                            {inv.key_stckA}
                                                        </div>
                                                        <div className="col-sm-12">
                                                            <input type="text" className="form-control" name={inv.frm_stckA} disabled></input>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div className="col-sm-4 offset-sm-2">
                                                    <div className="row">
                                                        <div className="col-sm-12 text-uppercase">
                                                            {inv.key_cantAd}
                                                        </div>
                                                        <div className="col-sm-12">
                                                            <input type="text" className="form-control" name={inv.frm_cantAd}></input>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div> 
                        </div> 
                    </div>
                }></GroupBox>
                </div>
            </div>

            </form>
                        <div className="row" style={{marginBottom:'20px'}}>
                <div className="col-sm-4 offset-sm-2">
                    <button type="button" className="btn btn-success" style={{width:'100%',marginTop:'10px'}} onClick={this.handleShow}>{inv.key_agIn}</button>
                </div>
                <div className="col-sm-4">
                     <button type="button" className="btn btn-primary" style={{width:'100%',marginTop:'10px'}}>{global.key_limp}</button>
                </div>
            </div>
            <ModalForms show={this.state.show} onHide={this.handleClose} conten={
                  <React.Fragment>
                     <div className="row">
                        <div className="col-sm-12 text-center text-uppercase">{inv.key_titM}</div>
                        <div className="col-sm-12 text-center text-uppercase">{inv.key_subtM}</div>
                        <div className="col-sm-4 text-center text-uppercase">{inv.key_numLoM}</div>
                        <div className="col-sm-4 text-center text-uppercase">{inv.key_cantM}</div>
                        <div className="col-sm-4 text-center text-uppercase">{inv.key_cadM}</div>
                        <div className="col-sm-12">
                            <div className="row">
                                <div className="col-sm-4"><input type="text" className="form-control"></input></div>
                                <div className="col-sm-4"><input type="text" className="form-control"></input></div>
                                <div className="col-sm-4"><input type="datetime-local" className="form-control"></input></div>
                            </div>
                        </div>
                        <div className="col-sm-2" style={{marginTop:'10px'}}>
                            <div className="form-group">
                                <Button variant="success">Agregar</Button>
                            </div>
                        </div>
                        <div className="col-sm-2 offset-sm-8" style={{marginTop:'10px'}}>
                            <div className="form-group">
                                <Button variant="danger">Eliminar</Button>
                            </div>
                        </div>
                    </div>    
                    <div className="row">
                        {
                            this.state.lotes.map((lote,i)=>{
                                return(
                                    <Lote numLote={lote.numLote} cantidad={lote.cantidad} fechaCaducidad={lote.fechaCaducidad}></Lote>
                                );
                            })
                        }
                        
                    </div> 
                </React.Fragment>
                

            } content_body={
                <div className="row">
                    <div className="col-sm-12">
                        <div className="d-flex flex-column">
                            <ButtonGroup className="mt-3">
                                <Button variant="danger" className="text-uppercase" onClick={this.handleClose}>{global.key_canc}</Button>
                                <Button variant="primary" className="text-uppercase">{global.key_acep}</Button>
                            </ButtonGroup>
                        </div> 
                    </div>
                </div>
            }>

            </ModalForms>
        </React.Fragment>   
        )
    };
      

}

export default Inventario;