import {Router } from "express";
import user from "./user";
import business from "./business";
import review from "./review";
import order from "./order";
import product from "./product";
import delivery from "./delivery";
import auth from "./auth";

const routes = Router();

routes.use("/auth", auth)
routes.use("/user",user);
routes.use("/bussines",business);
routes.use("/review",review);
routes.use("/order",order);
routes.use("/product",product);
routes.use("/delivery",delivery);
export default routes;