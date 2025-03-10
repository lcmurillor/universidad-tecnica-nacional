import { validate } from "class-validator";
import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { delivery } from "../entity/delivery";
 
export class delivery_controller {
    static createDelivery = async (req: Request, res: Response) => {
        const delivery_repo = getRepository(delivery);

        const _date= Date();
        const _delivery = new delivery(); 
        const {userID} = req.body;

        if (!userID) {
            return res.status(404).json({ message: "No indicó la cédula del usuario." });
        }
        _delivery.user = userID;
        
        _delivery.created_at = _date.toString();
        _delivery.updated_at = _date.toString();
        _delivery.state= '1';

        const validateOptions = { validationError: { target: false, value: false, children: false } };
        const mistakes = await validate(_delivery, validateOptions);
        if (mistakes.length > 0) {
            return res.status(400).json(mistakes);
        }
      
        try {
            await delivery_repo.save(_delivery);
        } catch (error) {
            return res.status(404).json({ message: "Error al intentar guardar el repartidor en la base de datos, revise los datos ingresados." });
        }
    }

    static getOneDelivery = async (req: Request, res: Response) => {

        const {id} = req.params;

        try {
            let _delivery = await getRepository(delivery).query(`select u.identity, u.full_name, u.phone, u.photo,
			u.identity as 'Cedula', 
            u.full_name as 'Nombre Completo',             
            u.phone as 'telefono',
            u.photo as 'Foto'
            from delivery as d
            inner join user as u on u.Id = d.userId
            where d.state = 'A' and d.id =`+id);
            return res.send(_delivery); 
        } catch (error) {
            return res.status(404).json({tittle:'Error', menssage: 'El repartidor no exite' });
        }

    }

    static getAllDelivery = async (req: Request, res: Response) => {
        const delivery_repo = getRepository(delivery);
        
        try {
            let _delivery = await getRepository(delivery).query(`select u.identity, u.full_name, u.phone, u.photo,
			u.identity as 'Cedula', 
            u.full_name as 'Nombre Completo',             
            u.phone as 'telefono',
            u.photo as 'Foto'
            from delivery as d
            inner join user as u on u.Id = d.userId
            where d.state = 'A'`);
            return res.send(_delivery);
        } catch (error) {
            return res.status(404).json({tittle:'Error', menssage: 'El repartidor no exite' });
        }

    }

    static updateDelivery = async (req: Request, res: Response) => {
        const delivery_repo = getRepository(delivery);
    }

    static deleteDelivery = async (req: Request, res: Response) => {
        const delivery_repo = getRepository(delivery);
        const { id } = req.params;
        let _delivery;

        try {
            _delivery = await delivery_repo.findOneOrFail(id);

        } catch (error) {
            return res.status(404).json({ message: "El repartidor indicado no existe." });
        }

        _delivery.status = "I";
        try {
            await delivery_repo.save(_delivery);
        } catch (error) {
            return res.status(404).json({ message: "Ha ocurrido un error al eliminar el repartidor del sistema." });
        }
        res.status(200).json({ message: "El repartidor se ha eliminado de manera exitosa." });
    }

}