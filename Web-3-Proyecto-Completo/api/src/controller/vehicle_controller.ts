import { validate } from "class-validator";
import { Request, Response } from "express";
import { getRepository } from "typeorm";
 import { vehicle } from "../entity/vehicle";

export class vehicle_Controller {
    
    static createVehicle = async (req:Request, res:Response) => {
        const vehicle_repo = getRepository(vehicle);

        const _date = Date();

        const { identity, mark , model, color, deliveryID} = req.body;

        
        if (!identity) {
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta el número de placa" });
        }
        if (!mark) {
            return res.status(400).json({ tittle:"Error al registrar" ,menssage: "Falta la marca" });
        }
        if (!model) {
            return res.status(400).json({tittle:"Error al registrar" , menssage: "Falta el modelo" });
        }
        if (!color) {
            return res.status(400).json({tittle:"Error al registrar" , menssage: "Falta el color" });
        }
        if (!deliveryID) {
            return res.status(400).json({tittle:"Error al registrar" , menssage: "No existe el repartidor" });
        }
     

        const _vehicle = new vehicle;

        _vehicle.identity = identity;
        _vehicle.mark = mark;
        _vehicle.model = model;
        _vehicle.color = color;
        _vehicle.created_at = _date.toString();
        _vehicle.updated_at = _date.toString();
        _vehicle.delivery = deliveryID;
        

        const _errores = await validate(_vehicle);

        if (_errores.length > 0) {
            return res.status(400).json(_errores);
        }

        try {
            await vehicle_repo.save(_vehicle);

        } catch (error) {
            return res.status(404).json({tittle:'Error', menssage:'El vehiculo no ha sido guardado'});

        }
        res.status(200).json({tittle:'Correcto', menssage:'El vehiculo ha sido guardado'});
    }
    
    static getOneVehicle = async (req:Request, res:Response) => {
        const vehicle_repo = getRepository(vehicle);
       
        let _vehicle;

        console.log(req.params);

        try {
            _vehicle = await vehicle_repo.findOneOrFail({
                select: ['identity', 'mark', 'model', 'color'], where: { id: req.params['id'] }
            });
            return res.send(_vehicle);
        } catch (error) {
            return res.status(404).json({tittle:'Error', menssage: 'El vehiculo no exite' });
        }
    }

    static updateVehicle = async (req:Request, res:Response) => {
        const vehicle_repo = getRepository(vehicle);
        const _date = Date();
        const{id} = req.params;
        let _vehicle;
        const { identity, mark , model, color} = req.body;

        
        if(!id){
            return res.status(400).json({tittle:'Error', menssage: 'Ingrese el ID' });
        }

        try {
            _vehicle = await vehicle_repo.findOneOrFail(id);
        } catch (error) {
            return res.status(404).json({tittle:'Error', menssage: 'El vehiculo no existe' });
        }

        if (identity) {
            _vehicle.identity = identity;
        }
        if (mark) {
            _vehicle.mark = mark;
        }
        if (model) {
            _vehicle.model = model;
        }
        if (color) {
            _vehicle.color = color;
        }

       
        _vehicle.updated_at = _date.toString();
        
        const validateOptions={validationError:{target: false, value: false,children: false}};

        const errores = await validate(_vehicle,validateOptions );
        if (errores.length > 0) {
            return res.status(400).json(errores);
        }

        try {
            await vehicle_repo.save(_vehicle);
        } catch (error) {
            return res.status(404).json({tittle:'Error', menssage: _vehicle });
        }
        res.status(200).json({tittle:'Actualizado', menssage: "El vehiculo se ha actualizado" });
    }

    static deleteVehicle = async (req:Request, res:Response) => {
        const vehicle_repo = getRepository(vehicle);  
        
        console.log(req.params);

        try {
            await vehicle_repo.delete(req.params);

            return res.status(200).json({tittle:'Eliminado', menssage: "El vehiculo ha sido eliminado" });
        } catch (error) {
            return res.status(404).json({tittle:'Error', menssage: 'Error al eliminar el vehiculo' });
        }
    }
}