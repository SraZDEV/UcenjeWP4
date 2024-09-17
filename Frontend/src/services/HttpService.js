import axios from "axios";
import { BACKEND_URL } from "../constants";


export const HttpService = axios.create({
    baseURL: BACKEND_URL,
    headers: {
        'Content-Type': 'application/json'
    }
});

async function obrisi(sifra){
    return await HttpService.Delete('/Smjer/' + sifra)
    .then((odgovor)=>{
        return {greska: false, poruka: odgovor.data.poruka}
    })
    .catch((e)=>{
        return {greska: true, poruka: 'Smjer se ne može obrisati'}
    })
}

export default{
    get
}