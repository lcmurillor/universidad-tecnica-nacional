import "reflect-metadata";
import {createConnection} from "typeorm";
import * as express from "express";
import * as bodyParser from "body-parser";
import {Request, Response} from "express";
import cors = require("cors");
import helmet = require("helmet");
import routes from "./routes";

const PORT = process.env.PORT || 3000;

createConnection().then(async connection => {

    // create express app
    const app = express();

    //Cors 
    app.use(cors());

    //Helmet
    app.use(helmet());

    //Express json 
    app.use(express.json());

    // register express routes from defined application routes
    app.use('/',routes);
    app.use("*",(req,res)=>{
        res.send("<h1>Estoy en el servidor</h1>")
    });

    // start express server
    app.listen(PORT,()=> {
        console.log(`Se levanto correctamente el servidor en el puerto: http://localhost:${PORT}/`)
    });

}).catch(error => console.log(error));
