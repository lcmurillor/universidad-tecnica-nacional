import { validate } from "class-validator";
import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { business } from "../entity/business";
import { product} from "../entity/product";
import { product_category } from "../entity/product_category";
import productRoutes from "../routes/Product";


export class product_controller {

    static createProduct =async (req:Request, res:Response)=>{
        const product_repo = getRepository(product);
        const _date= Date();
        const {name,description,photo,price,discount,offert_state,business_delivery_id,product_category_id,comment} = req.body;


        if(!name){
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta el nombre del producto" });
        }
        if(!description){
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta la descipcion del producto" });
        }
         if(!photo){
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta la foto del producto" });
        }
         if(!price){
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta el precio del producto" });
        }
         if(!discount){
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta el descuento del producto" });
        }
         if(!offert_state){
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta el estado de la oferta" });
        }
         if(!business_delivery_id){
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta el negocio" });
        }
         if(!product_category_id){
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta la categoria" });
        }
         if(!comment){
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta el comentario" });
        }

         const _product= new product;
 
         _product.name=name;
         _product.description=description;
         _product.photo=photo;
         _product.price=price;
         _product.discount=discount;
         _product.offert_state=offert_state;
         _product.state="A";
         _product.comment=comment;
         _product.created_at=_date.toString();
         _product.updated_at=_date.toString();
         _product.business_delivery_id=business_delivery_id;
         _product.product_category_id=product_category_id;
        

         const _errores = await validate(_product);

         if (_errores.length > 0) {
            return res.status(400).json(_errores);
        }

        try {
            await product_repo.save(_product);

        } catch (error) {
            return res.status(404).json(error);

        }
        res.status(200).json({tittle:'Correcto', menssage:'El producto ha sido guardado'});
      
    }

    static getAllProduct = async (req:Request, res:Response) => {
        
        let _product;
        const product_repo = getRepository(product);
        const { business } = req.params;
        
        if(!business){
            return res.status(400).json({mensaje:'Ingrese el id del repartidor'});
           }

        try {

            _product = await  product_repo.find(
            {select:['id','name','description','photo','price','discount','offert_state','business_delivery_id','product_category_id','comment'], where:{business_delivery_id:business,state:'A'}});
            
            return res.send(_product);
          
        } catch (error) {
             return res.status(404).json({mensaje:'Error al cargar la lista de productos'}); 
          }
          
    }

    static getOneProduct = async (req:Request, res:Response) => {
        
        let _product;
        const product_repo = getRepository(product);
        const { id } = req.params;
      
        if(!id){
         return res.status(400).json({mensaje:'Ingrese el id'});
        }
 
        try {
             _product = await product_repo.findOneOrFail( 
            {select:['id','name','description','photo','price','discount','offert_state','business_delivery_id','product_category_id','comment'], where:{id:id, state:'A' }} ); 
 
         } catch (error) {
             return res.status(404).json({mensaje:'El producto no se encontró.'});
         }
 
         return res.send(_product);
    }

    static updateProduct = async (req:Request, res:Response) => {
        
        const product_repo = getRepository(product);
        

        const _date= Date();
        const { id } = req.params;
        let _product;
        const {name,description,photo,price,discount,offert_state,business_id,product_category_id,comment} = req.body;


       if(!id){
        return res.status(400).json({mensaje:'Ingrese el id'});
       }

       try {
        
            _product = await product_repo.findOneOrFail(id); 

       } catch (error) {
            return res.status(404).json({mensaje:'Producto no se encontró.'});
       }


        if(name){
        _product.name= name;
       }
       if(description){
        _product.description= description;
       }
        if(photo){
         _product.photo= photo;
       }
        if(price){
         _product.price= price;
       }
        if(discount){
        _product.discount=discount;
        }
        if(offert_state){
         _product.offert_state=offert_state;
        }
        if (business_id){
        _product.business_delivery_id=business_id;
        }
        if (product_category_id){
        _product.product_category_id=product_category_id;
        }
        if(comment){
        _product.comment=comment;
        }

        //validar class validator
        _product.updated_at= _date.toString();
        


        const validateOptions= {validationError:{target:false, value:false}};
        const errores = await validate(_product, validateOptions );

        if(errores.length > 0){
            return res.status(400).json(errores);
        }

        try {

            await product_repo.save(_product);

        } catch (error) {

            return res.status(400).json({mensaje:error});        
        }

       return res.status(202).json({mensaje:'El producto se ha actualizado'});
      
    


    }

    static deleteProduct = async (req:Request, res:Response) => {

        let _product;  
        const product_repo = getRepository(product);  
        const { id } = req.params;
       
        if(!id){
            return res.status(400).json({mensaje:'Falta el id'});
           }
    
           try {
                 _product= await product_repo.findOneOrFail(id); 
    
            } catch (error) {
                return res.status(404).json({mensaje:'Producto no se encontro.'});
            }

        //Eliminar logico
        _product.state = "I";    
        try {
            await product_repo.save(_product);
        } catch (error) {
            return res.status(400).json({mensaje:error}); 
        } 

        return res.status(202).json({mensaje:'Se eliminó producto'});
    }
}