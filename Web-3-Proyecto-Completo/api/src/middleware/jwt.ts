import { NextFunction, Request, Response } from "express";
import * as jwt from 'jsonwebtoken';
import config from "../config/config";

export const checkJwt = (req: Request, res: Response, next: NextFunction) => {
    const token = <string>req.headers['auth'];
    let pay_load;

    try{
        pay_load = jwt.verify(token, config.jwtSecret);
        res.locals.jwtPayload = pay_load;
    } catch (error) {
        return res.status(401).json({mensaje: 'No Autorizado.'});
    }

    const {username, user_id} = pay_load;
    const new_token = jwt.sign(
        {username: username, user_id: user_id},
        config.jwtSecret,
        {expiresIn: '5m'}
    );

    res.setHeader('token', new_token);
    next();
}