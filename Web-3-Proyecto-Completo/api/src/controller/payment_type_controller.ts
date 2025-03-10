import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { payment_type } from "../entity/payment_type";

export class payment_type_controller{

    static getAllPaymentType = async (req:Request, res:Response) => {
    const payment_typeRepo = getRepository(payment_type);
    
    let payment_type_list;
    try {
    payment_type_list = await payment_typeRepo.find({
    select:['id','type', 'state', 'created_at', 'updated_at', 'order' ]
    ,where:{state:'A'}});
    return res.send(payment_type_list);
    } catch (error) {
    return res.status(400).json({title:'Acceso denegado', message:'Error al obtener métodos de pago'});
    }
    }
}