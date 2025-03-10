import { Request, Response } from "express";
import { getRepository } from "typeorm";
import { photo } from "../entity/photo";

export class photo_controller{
    static getAll = async (req:Request, res:Response) => {
        const photo_repo = getRepository(photo);
    }

    static getOne = async (req:Request, res:Response) => {
        const photo_repo = getRepository(photo);
    }

    static save = async (req:Request, res:Response) => {
        const photo_repo = getRepository(photo);
    }

    static update = async (req:Request, res:Response) => {
        const photo_repo = getRepository(photo);
    }

    static delete = async (req:Request, res:Response) => {
        const photo_repo = getRepository(photo);
    }
}