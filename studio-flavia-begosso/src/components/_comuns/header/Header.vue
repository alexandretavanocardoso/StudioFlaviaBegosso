<template>
    <div>
        <nav class="navbar navbar-expand-lg">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">LOGO</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                    data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <a @click="RenderizeValueHeader2('Página Inicial')" class="nav-link" aria-current="page" href="#">Página Inical</a>
                        </li>
                        <li class="nav-item">
                            <a @click="RenderizeValueHeader2('Quem Sou Eu')" class="nav-link" aria-current="page" href="#">Quem Sou Eu</a>
                        </li>
                        <li class="nav-item">
                            <a @click="RenderizeValueHeader2('Serviços')" class="nav-link" aria-current="page" href="#">Serviços</a>
                        </li>
                        <li class="nav-item">
                            <a @click="RenderizeValueHeader2('Galeria')" class="nav-link" aria-current="page" href="#">Galeria</a>
                        </li>
                        <li class="nav-item">
                            <a @click="RenderizeValueHeader2('Contato')" class="nav-link" aria-current="page" href="#">Contato</a>
                        </li>
                        <li class="nav-item">
                            <a @click="RenderizeValueHeader2('Blog')" class="nav-link" aria-current="page" href="#">Blog</a>
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