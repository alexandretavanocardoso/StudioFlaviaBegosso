<template>
    <div>
        <nav class="navbar navbar-expand-lg">
            <div class="container-fluid">
                <router-link @click="RenderizeValueHeader2('Página Inicial')" aria-current="page" class="navbar-brand" :to="{path: '/'}">LOGO</router-link>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                    data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <router-link @click="RenderizeValueHeader2('Página Inicial')" aria-current="page" class="nav-link" :to="{path: '/'}">Página Inical</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link @click="RenderizeValueHeader2('Quem Sou Eu')" aria-current="page" class="nav-link" :to="{path: '/sobre'}">Quem Sou Eu</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link @click="RenderizeValueHeader2('Serviços')" aria-current="page" class="nav-link" :to="{path: '/serviços'}">Serviços</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link @click="RenderizeValueHeader2('Galeria')" aria-current="page" class="nav-link" :to="{path: '/galeria'}">Galeria</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link @click="RenderizeValueHeader2('Contato')" aria-current="page" class="nav-link" :to="{path: '/contato'}">Contato</router-link>
                        </li>
                        <li class="nav-item">
                            <router-link @click="RenderizeValueHeader2('Blog')" aria-current="page" class="nav-link" :to="{path: '/blog'}">Blog</router-link>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>
</template> 

<script>
export default {
    name: 'HeaderComponent',
    methods: {
        RenderizeValueHeader2(page) {
            this.emitter.emit("titlePageEmit", page)
        }
    }
}
</script>

<style src="./Header.scss" lang="scss" scoped></style>