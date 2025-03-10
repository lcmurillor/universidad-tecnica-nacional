import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { product_category} from "../entity/product_category";

export class product_category_controller {
    
    static getAllProductCategory = async (req:Request, res:Response) => {
        const product_category_repo = getRepository(product_category);
        let _category;

        try {

            _category = await  product_category_repo.find(
            {select:['id','name','description','state','created_at','updated_at'], where:{state:'A'}});
    
    
            return res.send(_category);
              
          } catch (error) {
             return res.status(404).json({mensaje:'Error al cargar la lista de categorias'}); 
          }
    }

    static getOneProductCategory = async (req:Request, res:Response) => {
        
        let _category;
        const product_category_repo = getRepository(product_category);
        const { id } = req.params;
      
        if(!id){
         return res.status(400).json({mensaje:'Ingrese el id'});
        }
 
        try {
             _category = await product_category_repo.findOneOrFail( 
            {select:['id','name','description','state','created_at','updated_at'], where:{id:id, state:'A' }} ); 
 
         } catch (error) {
             return res.status(404).json({mensaje:'La categoria no se encontró.'});
         }
 
         return res.send(_category);
    }
}