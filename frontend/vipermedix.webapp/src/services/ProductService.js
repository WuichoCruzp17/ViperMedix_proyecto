
//Components
import {service} from '../utils/propertis';
import axios from 'axios';
axios.defaults.headers.post['Content-Type'] ='application/x-www-form-urlencoded';
axios.defaults.headers.post['Access-Control-Allow-Origin'] = '*';
const  ProductService = {

    getProduct: async(p_tipo,p_product_id,p_sucu_id, p_barcode)=>{
       var result = null;
      await  axios.get(service.path+"/product/*?p_tipo="+p_tipo+"&p_product_id="+p_product_id+"&p_sucu_id="+p_sucu_id+"&p_barcode="+p_barcode).
            then(res =>{
                result= res.data
            }).catch(function (error) {
                console.log(error);
            })
            
        return result;
    }
}

export default ProductService;