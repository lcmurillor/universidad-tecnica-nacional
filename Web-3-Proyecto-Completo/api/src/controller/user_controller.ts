import { validate } from "class-validator";
import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { user } from "../entity/user";

export class user_controller{
    static getAll = async (req:Request, res:Response) => {
        const user_repo = getRepository(user);
    }

    static getOne = async (req:Request, res:Response) => {
        const user_repo = getRepository(user);
    }

    static save = async (req:Request, res:Response) => {
        const user_repo = getRepository(user);
        const {
            identity,
            full_name,
            birthday,
            email,
            password,
            photo,
            phone
        } = req.body;

        const users = new user();

        users.identity = identity;
        users.full_name = full_name;
        users.birthday = birthday;
        users.email = email;
        users.password = password;
        users.photo = photo;
        users.phone = phone;
        users.state = "A";
        users.created_at = new Date().toLocaleString();
        users.updated_at = new Date().toLocaleString();

        if ( !identity ){
            return res.status(401).json({mensaje: 'Ingrese la cedula del usuario'});
        }

        if ( !full_name ){
            return res.status(401).json({mensaje: 'Ingrese el nombre completo del usuario'});
        }

        if ( !birthday ){
            return res.status(401).json({mensaje: 'Ingrese la fecha de Nacimiento'});
        }

        if ( !email ){
            return res.status(401).json({mensaje: 'Ingrese el e-mail del usuario'});
        }

        if ( !password ){
            return res.status(401).json({mensaje: 'Ingrese una Contraseña'});
        }

        if ( !photo ){
            return res.status(401).json({mensaje: 'Ingrese una foto'});
        }

        if ( !phone ){
            return res.status(401).json({mensaje: 'Ingrese un teléfono'});
        }
        
        const validate_options = { validationError: { target: false, value: false, children: false}};
        const errors = await validate(users, validate_options);

        if (errors.length > 0){
            return res.status(401).json(errors);
        }

        //users.hashPassword();

        try {
            await user_repo.save(users);
        } catch (error) {
            return res.status(404).json({mensaje: 'Usuario no Registrado'});
        }

        return res.status(200).json({mensaje: 'El Usuario se ha registrado satisfatoriamente'});
    }

    static update = async (req:Request, res:Response) => {
        const user_repo = getRepository(user);
        const { id } = req.params;
        const {
            identity,
            full_name,
            birthday,
            email,
            password,
            photo,
            phone,
            state
        } = req.body;
        let users;

        if ( !identity ){
            return res.status(401).json({mensaje: 'Ingrese la cedula del usuario'});
        }

        if ( !full_name ){
            return res.status(401).json({mensaje: 'Ingrese el nombre completo del usuario'});
        }

        if ( !birthday ){
            return res.status(401).json({mensaje: 'Ingrese la fecha de Nacimiento'});
        }

        if ( !email ){
            return res.status(401).json({mensaje: 'Ingrese el e-mail del usuario'});
        }

        if ( !password ){
            return res.status(401).json({mensaje: 'Ingrese una Contraseña'});
        }

        if ( !phone ){
            return res.status(401).json({mensaje: 'Ingrese un teléfono'});
        }

        if ( !phone ){
            return res.status(401).json({mensaje: 'Ingrese el estado del usuario'});
        }

        try {
            users = await user_repo.findOneOrFail(id);
        } catch (error) {
            return res.status(404).json({mnesaje: 'Usuario no Encontrado'});
        }

        users.identity = identity;
        users.full_name = full_name;
        users.birthday = birthday;
        users.email = email;
        users.password = password;
        users.photo = photo;
        users.phone = phone;
        users.state = state;
        users.updated_at = new Date().toLocaleString();

        const validate_options = { validationError: { target: false, value: false, children: false}};
        const errors = await validate(users, validate_options);

        if (errors.length > 0){
            return res.status(401).json(errors);
        }

        //users.hashPassword();
        
        try {
            await user_repo.save(users);
        } catch (error) {
            return res.status(404).json({mnesaje: 'Usuario no Actualizado'});
        }

        return res.status(200).json({Mensaje: 'El Usuario se ha Actualizado satisfatoriamente'});
    }

    static delete = async (req:Request, res:Response) => {
        const user_repo = getRepository(user);
        const { id } = req.params;
        let users;

        if ( !id ){
            return res.status(401).json({mensaje: 'Ingrese el ID del usuario'});
        }

        try {
            users = await user_repo.findOneOrFail(id);
        } catch (error) {
            return res.status(404).json({mnesaje: 'Usuario no Encontrado'});
        }

        users.state = "D";

        try {
            await user_repo.save(users);
        } catch (error) {
            return res.status(404).json({mnesaje: 'Usuario no Eliminado'});
        }

        return res.status(200).json({Mensaje: 'El Usuario se ha Eliminado satisfatoriamente'});

    }
}