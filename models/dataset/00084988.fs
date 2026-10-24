FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0", {"start": v(-4.740350947433837, 0) * mm, "end": v(4.740350947433855, 0) * mm});
            skLineSegment(sketch, "E1", {"start": v(4.740350947433854, 0) * mm, "end": v(4.235878725211635, 1.397) * mm});
            skLineSegment(sketch, "E2", {"start": v(4.235878725211636, 1.397) * mm, "end": v(-4.235878725211612, 1.397) * mm});
            skLineSegment(sketch, "E3", {"start": v(-4.235878725211612, 1.397) * mm, "end": v(-4.740350947433837, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 4.318 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E4.bottom", {"start": v(0.6096, 3.6262787252116357) * mm, "end": v(3.7084, 3.6262787252116357) * mm});
            skLineSegment(sketch, "E4.top", {"start": v(0.6096, -3.626278725211612) * mm, "end": v(3.7084, -3.626278725211612) * mm});
            skLineSegment(sketch, "E4.left", {"start": v(0.6096, 3.6262787252116357) * mm, "end": v(0.6096, -3.626278725211612) * mm});
            skLineSegment(sketch, "E4.right", {"start": v(3.7084, 3.626278725211635) * mm, "end": v(3.7084, -3.626278725211612) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])]});
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E5.bottom", {"start": v(0.6096, 4.130750947433836) * mm, "end": v(3.7084, 4.130750947433836) * mm});
            skLineSegment(sketch, "E5.top", {"start": v(0.6096, -4.130750947433854) * mm, "end": v(3.7084, -4.130750947433854) * mm});
            skLineSegment(sketch, "E5.left", {"start": v(0.6096, 4.130750947433837) * mm, "end": v(0.6096, -4.130750947433854) * mm});
            skLineSegment(sketch, "E5.right", {"start": v(3.7084, 4.130750947433837) * mm, "end": v(3.7084, -4.130750947433855) * mm});
            skSolve(sketch);
        }
        {
            var Q1;
            Q1 = qSketchRegion(id + "F2", true);
            var Q2;
            Q2 = qSketchRegion(id + "F3", true);
            loft(context, id + "F4", {"operationType" : NewBodyOperationType.REMOVE, "sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([Q1]) }, { "sheetProfileEntities" : qUnion([Q2]) }]});
        }
    });