import { validate } from "class-validator";
import { Request, Response } from "express";
import { getManager, getRepository } from "typeorm";
import { business } from "../entity/business";
import { phone } from "../entity/phone";
import { photo } from "../entity/photo";
import { user } from "../entity/user";

export class business_controller2 {

   
    /**
     * Permite la creacion de nuevos business y la incercion de los mismos en la base de datos.
     * Es necesario todos los datos para la creacion de un business, junto con otros datos que ya deven existir en la base de datos
     * como user y business_type para su correcta insercion.
     * Ejecuta sus respectivos controles y validaciones de los datos optenidos y los datos que devuelve.
     * en caso de presntar errores, retorna un mensaje de error con una descripcion breve del prblema.
     * @param req identity, name, address, open_time, close_time, user, business_type, tel, img.
     * @param res Codigo de status justo con un mensaje.
     * @returns Mensaje que indica si la insercion se ejecito correctamente o un mensaje que indique cual fue el error.
     */
    static async createBusiness(req: Request, res: Response) {
        const business_repo = getRepository(business);
        const photo_repo = getRepository(photo);
        const phone_repo = getRepository(phone);
        const { identity, name, address, open_time, close_time, user, business_type, tel, img } = req.body;
        //VALIDACION de existencia de datos.
        if (!identity) {
            return res.status(404).json({ mensaje: "No indicó la cédula juríduca del negocio." });
        } else if (!name) {
            return res.status(404).json({ mensaje: "No indicó el nombre del negocio." });
        } else if (!address) {
            return res.status(404).json({ mensaje: "No indicó la direción del negocio." });
        } else if (!close_time) {
            return res.status(404).json({ mensaje: "No indicó la hora de cierre del negocio." });
        } else if (!open_time) {
            return res.status(404).json({ mensaje: "No indicó la hora de apertura del negocio." });
        } else if (!user) {
            return res.status(404).json({ mensaje: "El usuario no está identificado." });
        } else if (!business_type) {
            return res.status(404).json({ mensaje: "El tipo de negocio no está identificado." });
        } else if (!tel) {
            return res.status(404).json({ mensaje: "No indicó nigún telefono del negocio." });
        } else if (!img) {
            return res.status(404).json({ mensaje: "No cargó ninguna foto del negocio." });
        }
        //CREACION del business.
        const _business = new business;
        let _date = new Date;
        const _phone = new phone;
        const _photo = new photo;
        _business.identity = identity;
        _business.name = name;
        _business.address = address;
        _business.open_time = open_time;
        _business.close_time = close_time;
        _business.user = user;
        _business.business_type = business_type;
        _business.created_at = _date.toString();
        _business.updated_at = _date.toString();
        _business.status = "A";

      


       
        //VALIDACION de errores en business.
        const validateOptions = { validationError: { target: false, value: false, children: false } };
        const mistakes = await validate(_business, validateOptions);
        if (mistakes.length > 0) {
            return res.status(400).json(mistakes);
        }
        //INCERSION de business en la base de datos. 
        try {
           
            await business_repo.save(_business); 
            _photo.name = img;
            _photo.business = _business;
            _photo.created_at = _date.toString();
            _photo.updated_at = _date.toString()
            await photo_repo.save(_photo);
            _phone.number = tel;
            _phone.business = _business;
            _phone.created_at = _date.toString();
            _phone.updated_at = _date.toString();
            await phone_repo.save(_phone);
        } catch (error) {
            return res.status(404).json({ mensaje: error});
        }
        
   
        res.status(201).json({ mensaje: "El negocio se a creado de manera exitosa." });
    }


    


}