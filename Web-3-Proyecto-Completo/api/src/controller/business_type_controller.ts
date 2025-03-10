import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { business_type } from "../entity/business_type";

export class business_type_controller {

    static getAllBusinessType = async (req: Request, res: Response) => {
        const business_type_repo = getRepository(business_type);
        let _businessType;

        try {
  
            _businessType = await business_type_repo.find({
              select: ['id','name','description' ], where: { state: 'A' }
           }
           );
  
           return res.send(_businessType)
  
        } catch (error) {
           return res.status(404).json({ mensaje: 'Error al cargar la lista de de Negocios' });
        }

    }


}