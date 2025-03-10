import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { phone } from "../entity/phone";

export class phone_controller{
    static getAll = async (req:Request, res:Response) => {
        const phone_repo = getRepository(phone);
    }

    static getOne = async (req:Request, res:Response) => {
        const phone_repo = getRepository(phone);
    }

    static save = async (req:Request, res:Response) => {
        const phone_repo = getRepository(phone);
    }

    static update = async (req:Request, res:Response) => {
        const phone_repo = getRepository(phone);
    }

    static delete = async (req:Request, res:Response) => {
        const phone_repo = getRepository(phone);
    }
}