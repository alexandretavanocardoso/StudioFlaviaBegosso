<template>
    <div class="mg-top">
        <div class="row" id="divQuestions">
            <div class="col-md-12">
                <p>Venha descobrir tudo sobre extensão de cilios o método que está transformando a <br /> beleza de
                    milhares de
                    mulheres.</p>
                <router-link @click="RenderizeValueHeader2('Perguntas Frequentes')" class="btn btn-dark"
                    :to="{ path: '/perguntas-frequentes' }">Saiba mais</router-link>
            </div>
        </div>
        <hr />
        <div class="row" id="divServices">
            <div class="col-md-12">
                <div class="imgServices">
                    <div class="col-md-4"><img src="@/assets/img/photoAbout.jpg" alt="" /></div>
                    <div class="col-md-4"><img src="@/assets/img/photoAbout.jpg" alt="" /></div>
                    <div class="col-md-4"><img src="@/assets/img/photoAbout.jpg" alt="" /></div>
                </div>
                <div class="divButton">
                    <router-link @click="RenderizeValueHeader2('Serviços')" class="btn btn-dark"
                        :to="{ path: '/serviços' }">Conheça os serviços!</router-link>
                </div>
            </div>
        </div>
        <hr />
        <div class="row" id="divAboutMe">
            <div class="col-md-12">
                <AboutMeComponent></AboutMeComponent>
            </div>
        </div>
        <hr />
        <div class="row" id="divGoogle">
            <div class="col-md-12">
                AVALIACOES GOOGLE
            </div>
        </div>
        <hr />
        <div class="row" id="divInstagram">
            <div class="col-md-12">
                CARD INSTAGRAM
            </div>
        </div>
        <hr />
        <div class="row" id="divBlog">
            <div class="col-md-12">
                <p>
                    Confira nosso blog com diversas dicas e curiosidades sobre extensão de cílios, além de ficar
                    por dentro de todas e quaisquer novidades do studio, como promoções ou novos serviços!
                </p>
                <router-link @click="RenderizeValueHeader2('BLOG')" class="btn btn-dark" :to="{ path: '/blog' }">Ir para
                    blog</router-link>
            </div>
        </div>
        <hr />
        <div class="row" id="divContanct">
            <div class="col-md-12">
                <ContactComponent></ContactComponent>
            </div>
        </div>
    </div>
</template>

<script>
import AboutMeComponent from '@/components/studio-components/about-me/AboutMe.vue'
import ContactComponent from '@/components/studio-components/contact/Contact.vue'

export default {
    name: 'HomeComponent',
    components: {
        AboutMeComponent,
        ContactComponent
    },
    methods: {
        RenderizeValueHeader2(page) {
            this.emitter.emit("titlePageEmit", page)
        }
    }
}
</script>

<style src="./Home.scss" lang="scss" scoped>

</style>