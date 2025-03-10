import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { user } from "../entity/user";
import * as jwt from 'jsonwebtoken';
import config from "../config/config";

export class auth_controller{
    static login = async (req:Request, res:Response) => {
        const user_repo = getRepository(user);
        const {
            email,
            password
        } = req.body;

        if(!(email && password)){
            return res.status(401).json({mensaje: 'Nombre de Usuario o Contraseña Incorrecto'});
        }

        let _user: user;

        try {
            _user = await user_repo.findOneOrFail({where:{email: email}});
        } catch (error) {
            return res.status(401).json({mensaje: 'Nombre de Usuario o Contraseña Incorrecto'});
        }

        if(!(_user.password === password)){
            return res.status(401).json({mensaje: 'Nombre de Usuario o Contraseña Incorrecto'});
        }

        const token = jwt.sign(
            {username: _user.email, user_id: _user.Id},
            config.jwtSecret,
            {expiresIn:'5m'}
        );

        return res.json({token, _user});
    }
}