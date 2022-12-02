<template>
    <div class="mg-top">
        <h3 class="title-default">EXTENSÃO DE CÍLIOS</h3>
        <div class="flex">
            <div class="card" v-for="(work, index) in works" :key="index">
                <div class="card-body">
                    <img :src="work.image" class="card-img-top" alt="...">
                    <h5 class="card-title">{{ work.name }}</h5>
                    <p class="card-text">{{ work.description }}</p>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'AllWorksComponent',
    data: () => ({
        works: [
            {
                image: "https://img1.wsimg.com/isteam/ip/f99643a2-98fa-4b82-a798-f237e15eac00/WhatsApp%20Image%202022-03-04%20at%2007.45.08-2.jpeg/:/cr=t:33.7%25,l:12.29%25,w:64.94%25,h:48.7%25/rs=w:360,h:360,cg:true,m",
                name: "FIO À FIO CLÁSSICO",
                description: "São Fios de extensões colocados um a um, diretamente nos cílios a 0.2 cm de distância da pele. As extensões proporcionam um olhar leve e natural e tem durabilidade de aproximadamente 30 dias. Mas para cílios impecáveis o ideal é a manutenção em 21 dias."
            },
            {
                image: "https://img1.wsimg.com/isteam/ip/f99643a2-98fa-4b82-a798-f237e15eac00/WhatsApp%20Image%202022-03-04%20at%2007.45.08-2.jpeg/:/cr=t:33.7%25,l:12.29%25,w:64.94%25,h:48.7%25/rs=w:360,h:360,cg:true,m",
                name: "VOLUME FASHION",
                description: "Nesse fio à fio aplicamos um fio diferenciado. Ele é mais destacado e possui efeito rímel. Indicado para quem quer destacar o olhar e possui muitos fios."
            },
            {
                image: "https://img1.wsimg.com/isteam/ip/f99643a2-98fa-4b82-a798-f237e15eac00/WhatsApp%20Image%202022-03-04%20at%2007.45.08-2.jpeg/:/cr=t:33.7%25,l:12.29%25,w:64.94%25,h:48.7%25/rs=w:360,h:360,cg:true,m",
                name: "VOLUME GLAMOUR",
                description: "São extensões macias e leves que trazem volume, leveza e, ainda assim, proporcionam um olhar dramático. São criados leques de 3 a 7 fios em cada fio natural, chegando a totalizar mais de 500 fios sintéticos. No final do procedimento você terá um olhar preto e volumoso, mas com fios macios e naturais."
            }
        ]
    })
}
</script>

<style src="./AllWorks.scss" lang="scss" scoped>

</style>