import { Router } from "express";
import { auth_controller } from "../controller/auth_controller";

const authRoutes = Router();

authRoutes.post('/login', auth_controller.login);

export default authRoutes;