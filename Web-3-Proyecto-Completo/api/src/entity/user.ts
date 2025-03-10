import { IsDate, IsEmail, IsNotEmpty, IsPhoneNumber, Matches, MaxLength, MinLength } from "class-validator";
import { Column, Entity, OneToMany, OneToOne, PrimaryGeneratedColumn, Unique } from "typeorm";
import { review } from "./review";
import { business } from "./business";
import { order } from "./order";
import { address } from "./address";
import * as bcrypt from 'bcryptjs';

@Entity()
@Unique(['identity', 'email'])
export class user{
    @PrimaryGeneratedColumn()
    Id: number;

    @Column() @IsNotEmpty() @MaxLength(15) @MinLength(9) 
    identity: string;

    @Column() @IsNotEmpty() @MaxLength(100)
    full_name: string;

    @Column() @IsNotEmpty() @MaxLength(10)
    // @Matches(/(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/](19|20)\d\d/, {
    //     message: "$property must be formatted as dd/mm/yyyy"
    // })
    birthday: string;
    
    @Column() @IsNotEmpty() @MaxLength(100) @IsEmail()
    email: string;

    @Column() @IsNotEmpty() @MaxLength(50) @MinLength(6)
    // @Matches(/^(?:(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*)[^\s]{6,}$/, {
    //     message: "$property must be uppercase, lowercase, and have a minimum length of 6 characters"
    // })
    password: string;

    @Column() @IsNotEmpty() @MaxLength(3500) 
    photo: string;


    //@MaxLength(15)
    // @Matches(/^\(?([0-9]{4})\)?[-]?([0-9]{2})[-]?([0-9]{2})$/, {
    //     message: "$property must be formatted as xxxx-xx-xx"
    // })   
     @Column() @IsNotEmpty() 
    phone: string;

    @Column() @IsNotEmpty() @MaxLength(1)
    state: string;
    
    @Column() @IsNotEmpty()
    created_at: string;

    @Column() @IsNotEmpty()
    updated_at: string;

    @OneToMany(type => review, review => review.user)
    review: review[];

    @OneToMany(type => business, business => business.user)
    business: business[];

    @OneToMany(type => order, order => order.user)
    order: order[];
    
    @OneToMany(type => address, address => address.user)
    address: address[];

    hashPassword():void{
        const salt = bcrypt.genSaltSync(10);

        this.password = bcrypt.hashSync(this.password, salt);
    }

    checkPassword(password: string): boolean{
        return bcrypt.compareSync(password, this.password);
    }
}
