
import { validate } from "class-validator";
import { Console } from "console";
import{Request,Response} from "express";
import { getRepository } from "typeorm";
import { order } from "../entity/order";

export class order_controller {
    static getAll = async (req: Request, res: Response) => {
        const order_repo = getRepository(order);
        
        let orderList;
             try {
                orderList=await order_repo.find({
                    select:['id','date','order_state',
                            'details','state','created_at','business','payment_type','user',]
                            ,where:{state:'A',business:req.params['id']}});
                   return res.send(orderList);
                } catch (error) {
                 return res.status(404).json({tittle:'Error al registrar',message:'Error al cargar la lista de Order'});
              }
    }

    static getOne = async (req: Request, res: Response) => {
        const order_repo = getRepository(order);
        try {
            let order_one;
            order_one = await order_repo.findOne({
               select: ['id','date','order_state',
               'details','state','created_at','updated_at','updated_at','business','payment_type','user'],
                where: { id: req.params['id'],state:'A' }
            });
            if(!order_one){
               return res.status(401).json({tittle:'Error al registrar', message: 'El id order no existe' });
            }
            return res.send(order_one);
         } catch (error) {
            return res.status(404).json({tittle:'Error al registrar', message: 'Error al cargar la orden' });
         }
    }
     /* Metodo que recibe de momento el id propio y los de relación */
    static createOrder = async (req: Request, res: Response) => {
        const order_repo = getRepository(order);
        const {date,order_state,
            details,business,payment_type,user}= req.body;
             if (!date) {
               return res.status(401).json({tittle:'Error al registrar',message:'Falta el fecha'});
               } if (!order_state) {
                return res.status(401).json({tittle:'Error al registrar',message:'Falta el estado de orden'});
               }if (!details) {
                return res.status(401).json({tittle:'Error al registrar',message:'Falta el detalle'});
               } if (!business) {
                return res.status(401).json({tittle:'Error al registrar',message:'Falta el negocio'});
               } if (!payment_type) {
                return res.status(401).json({tittle:'Error al registrar',message:'Falta el tipo de pago'});
               } if (!user) {
                return res.status(401).json({tittle:'Error al registrar',message:'Falta el id del usuario'});
               } 
           const order_Entity = new order();
           order_Entity.date=date;
           order_Entity.order_state=order_state;
           order_Entity.details=details;
           order_Entity.created_at=new Date().toLocaleString();
           order_Entity.updated_at=new Date().toLocaleString();
           order_Entity.business=business;
           order_Entity.payment_type=payment_type;
           order_Entity.user=user;
           order_Entity.state='A';
           const validateOption={validationError:{target:false,value:false,children:false}};
           const errores = await validate(order,validateOption);
           if(errores.length>0){
             return res.status(401).json(errores);
           }
           try {
            order_repo.save(order_Entity);
               return res.send({message:'guardado con exito',order_Entity});
           } catch (error) {
            return res.status(404).json({tittle:'Error',message:'Error al guardar'});
           }
    }
 
    static updateOrder = async (req: Request, res: Response) => {
        const order_repo = getRepository(order);
        let order_Entity;
        const  id_params =req.params;
        const {date,order_state,
            details,business,payment_type,user}= req.body;
         if (!id_params) {
            return res.status(401).json({tittle:'Error al registrar',message:'Falta el id'});
           } if (!date) {
           return res.status(401).json({tittle:'Error al registrar',message:'Falta el fecha'});
           }if (!order_state) {
            return res.status(401).json({tittle:'Error al registrar',message:'Falta el estado de orden'});
           }if (!details) {
            return res.status(401).json({tittle:'Error al registrar',message:'Falta el detalle'});
           }  if (!business) {
            return res.status(401).json({tittle:'Error al registrar',message:'Falta el negocio'});
           } if (!payment_type) {
            return res.status(401).json({tittle:'Error al registrar',message:'Falta el tipo de pago'});
           } if (!user) {
            return res.status(401).json({tittle:'Error al registrar', message:'Falta el id usuario'});
           } 
           try {
            order_Entity= await order_repo.findOneOrFail(id_params);
            } catch (error) {
            return res.status(404).json({ tittle:'Error al registrar',message: 'No se encontro la orden' });
            }
        order_Entity.date=date;
        order_Entity.order_state=order_state;
        order_Entity.details=details;
        order_Entity.updated_at=new Date().toLocaleString();
        order_Entity.business=business;
        order_Entity.payment_type=payment_type;
        order_Entity.user=user;
     const validateOption={validationError:{target:false,value:false,children:false}};
     const errores = await validate(order,validateOption);
     if(errores.length>0){
       return res.status(401).json(errores);
     }
    try {
        order_Entity=await order_repo.save(order_Entity);
         return res.send({message:'Actualizado con exito',order_Entity});
    } catch (error) {
      return res.status(401).json({message:error});
    }

    }
    /* eliminado logico */
    static deleteOrder = async (req: Request, res: Response) => {
        const order_repo = getRepository(order);
        let order_Entity;
        const  id_params =req.params;
        if (!id_params) {
            return res.status(401).json({tittle:'Error al registrar', message: 'Falta el ID' });
        }
        try {
            order_Entity= await order_repo.findOneOrFail(id_params);
        } catch (error) {
            return res.status(404).json({tittle:'Error al registrar', message: 'No se encontro la orden' });
        }
        order_Entity.state='I';
        try {
            await order_repo.save(order_Entity);
        } catch (error) {
        return res.status(401).json({ message: error });
        }
        return res.status(202).json({tittle:'Proceso finalizado',message: "se elimino con exito"});
        }
    }
